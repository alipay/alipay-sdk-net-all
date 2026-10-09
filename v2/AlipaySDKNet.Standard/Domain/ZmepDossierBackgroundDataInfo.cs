using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ZmepDossierBackgroundDataInfo Data Structure.
    /// </summary>
    [Serializable]
    public class ZmepDossierBackgroundDataInfo : AopObject
    {
        /// <summary>
        /// 数据结果
        /// </summary>
        [XmlArray("hits")]
        [XmlArrayItem("zmep_dossier_background_info")]
        public List<ZmepDossierBackgroundInfo> Hits { get; set; }

        /// <summary>
        /// 结果总条数
        /// </summary>
        [XmlElement("total")]
        public long Total { get; set; }
    }
}
