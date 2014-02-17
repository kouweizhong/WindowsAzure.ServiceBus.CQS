﻿using System;
using System.Runtime.Serialization;

namespace WindowsAzure.ServiceBus.Cqs
{
    /// <summary>
    ///     Command bus is broken and can not recover. Create a new command bus instance.
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         Something is wrong with the created Azure message queue. You need to check the configuration, network access
    ///         etc.
    ///     </para>
    /// </remarks>
    [Serializable]
    public class FatalBusException : Exception
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="FatalBusException"/> class.
        /// </summary>
        public FatalBusException()
            : base("Bus is broken. Check the inner exception.")
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FatalBusException"/> class.
        /// </summary>
        /// <param name="message">The message that describes the error.</param>
        public FatalBusException(string message) : base(message)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FatalBusException"/> class.
        /// </summary>
        /// <param name="message">The message.</param>
        /// <param name="inner">The inner.</param>
        public FatalBusException(string message, Exception inner) : base(message, inner)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FatalBusException"/> class.
        /// </summary>
        /// <param name="inner">The inner.</param>
        public FatalBusException(Exception inner)
            : base("Bus is broken. Check the inner exception.", inner)
        {
        }


        /// <summary>
        /// Initializes a new instance of the <see cref="FatalBusException"/> class.
        /// </summary>
        /// <param name="info">The <see cref="T:System.Runtime.Serialization.SerializationInfo" /> that holds the serialized object data about the exception being thrown.</param>
        /// <param name="context">The <see cref="T:System.Runtime.Serialization.StreamingContext" /> that contains contextual information about the source or destination.</param>
        protected FatalBusException(
            SerializationInfo info,
            StreamingContext context) : base(info, context)
        {
        }

        /// <summary>
        /// When overridden in a derived class, sets the <see cref="T:System.Runtime.Serialization.SerializationInfo" /> with information about the exception.
        /// </summary>
        /// <param name="info">The <see cref="T:System.Runtime.Serialization.SerializationInfo" /> that holds the serialized object data about the exception being thrown.</param>
        /// <param name="context">The <see cref="T:System.Runtime.Serialization.StreamingContext" /> that contains contextual information about the source or destination.</param>
        /// <PermissionSet>
        ///   <IPermission class="System.Security.Permissions.FileIOPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Read="*AllFiles*" PathDiscovery="*AllFiles*" />
        ///   <IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="SerializationFormatter" />
        ///   </PermissionSet>
        public override void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            base.GetObjectData(info, context);
        }
    }
}