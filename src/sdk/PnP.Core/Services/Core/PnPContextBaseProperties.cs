using PnP.Core.Model.SharePoint;
using System;

namespace PnP.Core.Services
{
    /// <summary>
    /// Context base properties
    /// </summary>
    public class PnPContextBaseProperties
    {
        /// <summary>
        /// Site Id to set on the context during creation
        /// </summary>
        public Guid SiteId { get; set; }

        /// <summary>
        /// Web Id to set on the context during creation
        /// </summary>
        public Guid WebId { get; set; }

        /// <summary>
        /// Group Id to set on the context during creation
        /// </summary>
        public Guid GroupId { get; set; }

        /// <summary>
        /// Regional Settings to set on the context during creation
        /// </summary>
        public IRegionalSettings RegionalSettings { get; set; }
    }
}
