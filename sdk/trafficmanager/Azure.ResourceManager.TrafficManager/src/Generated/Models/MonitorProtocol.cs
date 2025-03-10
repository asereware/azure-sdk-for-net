// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.TrafficManager.Models
{
    /// <summary> The protocol (HTTP, HTTPS or TCP) used to probe for endpoint health. </summary>
    public readonly partial struct MonitorProtocol : IEquatable<MonitorProtocol>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="MonitorProtocol"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public MonitorProtocol(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string HttpValue = "HTTP";
        private const string HttpsValue = "HTTPS";
        private const string TCPValue = "TCP";

        /// <summary> HTTP. </summary>
        public static MonitorProtocol Http { get; } = new MonitorProtocol(HttpValue);
        /// <summary> HTTPS. </summary>
        public static MonitorProtocol Https { get; } = new MonitorProtocol(HttpsValue);
        /// <summary> TCP. </summary>
        public static MonitorProtocol TCP { get; } = new MonitorProtocol(TCPValue);
        /// <summary> Determines if two <see cref="MonitorProtocol"/> values are the same. </summary>
        public static bool operator ==(MonitorProtocol left, MonitorProtocol right) => left.Equals(right);
        /// <summary> Determines if two <see cref="MonitorProtocol"/> values are not the same. </summary>
        public static bool operator !=(MonitorProtocol left, MonitorProtocol right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="MonitorProtocol"/>. </summary>
        public static implicit operator MonitorProtocol(string value) => new MonitorProtocol(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is MonitorProtocol other && Equals(other);
        /// <inheritdoc />
        public bool Equals(MonitorProtocol other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
