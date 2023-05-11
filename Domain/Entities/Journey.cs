namespace Domain.Entities
{
    using Domain.Common;
    using System.Collections.Generic;

    /// <summary>
    /// Defines the <see cref="Journey" />.
    /// </summary>
    public class Journey : AuditableBaseEntity
    {
        /// <summary>
        /// Gets or sets the Flights.
        /// </summary>
        public List<Flight> Flights { get; set; }

        /// <summary>
        /// Gets or sets the Origin.
        /// </summary>
        public string Origin { get; set; }

        /// <summary>
        /// Gets or sets the Destination.
        /// </summary>
        public string Destination { get; set; }

        /// <summary>
        /// Gets or sets the Price.
        /// </summary>
        public double Price { get; set; }
    }
}
