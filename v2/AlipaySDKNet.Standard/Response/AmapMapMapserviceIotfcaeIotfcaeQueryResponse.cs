using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Response
{
    /// <summary>
    /// AmapMapMapserviceIotfcaeIotfcaeQueryResponse.
    /// </summary>
    public class AmapMapMapserviceIotfcaeIotfcaeQueryResponse : AopResponse
    {
        /// <summary>
        /// 证件号
        /// </summary>
        [XmlElement("cert_no")]
        public string CertNo { get; set; }

        /// <summary>
        /// dkjkvgfdugdfugh
        /// </summary>
        [XmlArray("data_list")]
        [XmlArrayItem("string")]
        public List<string> DataList { get; set; }

        /// <summary>
        /// vgdfskvghdflgjdfkf
        /// </summary>
        [XmlElement("expire_date")]
        public string ExpireDate { get; set; }

        /// <summary>
        /// vfsvgdfghdf
        /// </summary>
        [XmlElement("name")]
        public string Name { get; set; }
    }
}
