namespace Domain.Common
{
    using System;

    /// <summary>
    /// Defines the <see cref="AuditableBaseEntity" />.
    /// </summary>
    public abstract class AuditableBaseEntity
    {
        /// <summary>
        /// Gets or sets the Id.
        /// </summary>
        public virtual int Id { get; set; }

        /// <summary>
        /// Gets or sets the CreateBy.
        /// </summary>
        public string CreateBy { get; set; }

        /// <summary>
        /// Gets or sets the Created.
        /// </summary>
        public DateTime Created { get; set; }

        /// <summary>
        /// Gets or sets the LastModifiedBy.
        /// </summary>
        public string LastModifiedBy { get; set; }

        /// <summary>
        /// Gets or sets the LastModified.
        /// </summary>
        public DateTime? LastModified { get; set; }
    }
}
