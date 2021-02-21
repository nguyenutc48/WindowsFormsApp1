﻿using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace WindowsFormsApp1
{
    [Serializable]
    public class Bindable : INotifyPropertyChanged
    {
        // INotifyPropertyChanged Implementation

        [field: NonSerialized] // this event should not be serialized by a formatter (error may occur)
        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// Child class may call this method explicitly in the property setter
        /// </summary>
        /// <param name="property"></param>
        protected virtual void Notify([CallerMemberName] string property = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(property));
        }

        // Shortcuts to quickly set property value

        /// <summary>
        /// Set value to a property and raise the PropertyChanged event
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="member"></param>
        /// <param name="value"></param>
        /// <param name="property"></param>
        protected virtual void Set<T>(ref T member, T value, [CallerMemberName] string property = null)
        {
            if (Equals(member, value)) return;
            member = value;
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(property));
        }

        /// <summary>
        /// Set value to a property, raise the PropertyChanged event of itself and a list of other properties
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="member"></param>
        /// <param name="value"></param>
        /// <param name="properties">The related properties to be notified</param>
        /// <param name="property"></param>
        protected virtual void Set<T>(ref T member, T value, string[] properties, [CallerMemberName] string property = null)
        {
            if (Equals(member, value)) return;
            member = value;
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(property));

            if (properties.Length <= 0) return;
            foreach (var p in properties)
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(p));
        }

        /// <summary>
        /// Set value to a property as well as a predicate to validate value.
        /// This requires the control to enable the ValidatesOnExceptions in the binding
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="member"></param>
        /// <param name="value"></param>
        /// <param name="predicate">A predicate to check the input</param>
        /// <param name="message">A message to display when invalid input occurs</param>
        /// <param name="property"></param>
        protected virtual void Set<T>(ref T member, T value, Predicate<T> predicate, string message, [CallerMemberName] string property = null)
        {
            if (Equals(member, value)) return;
            if (!predicate(value)) throw new Exception(message);
            member = value;
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(property));
        }
    }
    
}

