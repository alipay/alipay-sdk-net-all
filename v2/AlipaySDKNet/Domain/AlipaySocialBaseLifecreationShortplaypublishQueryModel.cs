using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipaySocialBaseLifecreationShortplaypublishQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipaySocialBaseLifecreationShortplaypublishQueryModel : AopObject
    {
        /// <summary>
        /// 短剧ID（剧库ID）。
        /// </summary>
        [XmlElement("album_id")]
        public string AlbumId { get; set; }
    }
}
