using PnP.Core.Model.SharePoint;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace PnP.Core.Services
{
    /// <summary>
    /// Options used when a <see cref="PnPContext"/> is created
    /// </summary>
    public class PnPContextOptions
    {
        /// <summary>
        /// Additional <seealso cref="ISite"/> properties to load when creating a new <seealso cref="PnPContext"/>.
        /// </summary>
        public IEnumerable<Expression<Func<ISite, object>>> AdditionalSitePropertiesOnCreate { get; set; }

        /// <summary>
        /// Additional <seealso cref="IWeb"/> properties to load when creating a new <seealso cref="PnPContext"/>.
        /// </summary>
        public IEnumerable<Expression<Func<IWeb, object>>> AdditionalWebPropertiesOnCreate { get; set; }

        /// <summary>
        /// Properties to set on the context during creation
        /// </summary>
        public IDictionary<string, object> Properties { get; set; }

        /// <summary>
        /// Site Id to set on the context during creation
        /// </summary>
        public string SiteId { get; set; }

        /// <summary>
        /// Web Id to set on the context during creation
        /// </summary>
        public string WebId { get; set; }

        /// <summary>
        /// Group Id to set on the context during creation
        /// </summary>
        public string GroupId { get; set; }

        /// <summary>
        /// Regional Settings to set on the context during creation
        /// </summary>
        public IRegionalSettings RegionalSettings { get; set; }
    }
}
