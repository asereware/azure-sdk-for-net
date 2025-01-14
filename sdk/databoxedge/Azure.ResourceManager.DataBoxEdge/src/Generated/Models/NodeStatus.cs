// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.DataBoxEdge.Models
{
    /// <summary> The current status of the individual node. </summary>
    public readonly partial struct NodeStatus : IEquatable<NodeStatus>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="NodeStatus"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public NodeStatus(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string UnknownValue = "Unknown";
        private const string UpValue = "Up";
        private const string DownValue = "Down";
        private const string RebootingValue = "Rebooting";
        private const string ShuttingDownValue = "ShuttingDown";

        /// <summary> Unknown. </summary>
        public static NodeStatus Unknown { get; } = new NodeStatus(UnknownValue);
        /// <summary> Up. </summary>
        public static NodeStatus Up { get; } = new NodeStatus(UpValue);
        /// <summary> Down. </summary>
        public static NodeStatus Down { get; } = new NodeStatus(DownValue);
        /// <summary> Rebooting. </summary>
        public static NodeStatus Rebooting { get; } = new NodeStatus(RebootingValue);
        /// <summary> ShuttingDown. </summary>
        public static NodeStatus ShuttingDown { get; } = new NodeStatus(ShuttingDownValue);
        /// <summary> Determines if two <see cref="NodeStatus"/> values are the same. </summary>
        public static bool operator ==(NodeStatus left, NodeStatus right) => left.Equals(right);
        /// <summary> Determines if two <see cref="NodeStatus"/> values are not the same. </summary>
        public static bool operator !=(NodeStatus left, NodeStatus right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="NodeStatus"/>. </summary>
        public static implicit operator NodeStatus(string value) => new NodeStatus(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is NodeStatus other && Equals(other);
        /// <inheritdoc />
        public bool Equals(NodeStatus other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
