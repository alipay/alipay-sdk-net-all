using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipaySocialBaseLifecreationShortplaydetailQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipaySocialBaseLifecreationShortplaydetailQueryModel : AopObject
    {
        /// <summary>
        /// 短剧ID（剧库ID）。
        /// </summary>
        [XmlElement("album_id")]
        public string AlbumId { get; set; }
    }
}
