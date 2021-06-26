namespace Mbmd
{
    using System;

    /// <summary>
    /// Represents an entity.
    /// </summary>
    public interface IEntity
    {
        /// <summary>
        /// Gets or sets the ID of the entity.
        /// </summary>
        Guid Id { get; set; }
    }
}
