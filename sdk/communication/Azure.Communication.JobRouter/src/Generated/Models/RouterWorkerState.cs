// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.Communication.JobRouter
{
    /// <summary> The current state of the worker. </summary>
    public readonly partial struct RouterWorkerState : IEquatable<RouterWorkerState>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="RouterWorkerState"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public RouterWorkerState(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string ActiveValue = "active";
        private const string DrainingValue = "draining";
        private const string InactiveValue = "inactive";

        /// <summary> active. </summary>
        public static RouterWorkerState Active { get; } = new RouterWorkerState(ActiveValue);
        /// <summary> draining. </summary>
        public static RouterWorkerState Draining { get; } = new RouterWorkerState(DrainingValue);
        /// <summary> inactive. </summary>
        public static RouterWorkerState Inactive { get; } = new RouterWorkerState(InactiveValue);
        /// <summary> Determines if two <see cref="RouterWorkerState"/> values are the same. </summary>
        public static bool operator ==(RouterWorkerState left, RouterWorkerState right) => left.Equals(right);
        /// <summary> Determines if two <see cref="RouterWorkerState"/> values are not the same. </summary>
        public static bool operator !=(RouterWorkerState left, RouterWorkerState right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="RouterWorkerState"/>. </summary>
        public static implicit operator RouterWorkerState(string value) => new RouterWorkerState(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is RouterWorkerState other && Equals(other);
        /// <inheritdoc />
        public bool Equals(RouterWorkerState other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
