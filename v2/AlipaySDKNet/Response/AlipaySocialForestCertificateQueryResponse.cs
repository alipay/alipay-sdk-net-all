using System;
using System.Xml.Serialization;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipaySocialForestCertificateQueryResponse.
    /// </summary>
    public class AlipaySocialForestCertificateQueryResponse : AopResponse
    {
        /// <summary>
        /// 对应树种的证书数量，JSON
        /// </summary>
        [XmlElement("cert_count_by_tree")]
        public string CertCountByTree { get; set; }

        /// <summary>
        /// 当前用户是否是森林用户
        /// </summary>
        [XmlElement("forest_user")]
        public bool ForestUser { get; set; }

        /// <summary>
        /// 用户所有已经种下的树种的林区信息
        /// </summary>
        [XmlElement("plant_place_info")]
        public PlantPlace PlantPlaceInfo { get; set; }

        /// <summary>
        /// 用户碳账户总能量
        /// </summary>
        [XmlElement("total_carbon_amount")]
        public long TotalCarbonAmount { get; set; }

        /// <summary>
        /// 用户低碳行为总次数
        /// </summary>
        [XmlElement("total_carbon_count")]
        public long TotalCarbonCount { get; set; }

        /// <summary>
        /// 用户环保证书总数量
        /// </summary>
        [XmlElement("total_cert_count")]
        public long TotalCertCount { get; set; }

        /// <summary>
        /// 用户的证书列表，只透出最近的几个
        /// </summary>
        [XmlElement("user_certs")]
        public UserCert UserCerts { get; set; }
    }
}
