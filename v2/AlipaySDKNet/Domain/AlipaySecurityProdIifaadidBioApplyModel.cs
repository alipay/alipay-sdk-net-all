using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipaySecurityProdIifaadidBioApplyModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipaySecurityProdIifaadidBioApplyModel : AopObject
    {
        /// <summary>
        /// 业务请求的唯一流水ID
        /// </summary>
        [XmlElement("biz_id")]
        public string BizId { get; set; }

        /// <summary>
        /// IIFAA为用户设备申请的唯一标识，用户在分布式系统中的身份标识
        /// </summary>
        [XmlElement("did")]
        public string Did { get; set; }

        /// <summary>
        /// 用户设备中的环境信息
        /// </summary>
        [XmlElement("env_data")]
        public string EnvData { get; set; }

        /// <summary>
        /// 用户开通本地生物的安全数据
        /// </summary>
        [XmlElement("ifaa_msg")]
        public string IfaaMsg { get; set; }

        /// <summary>
        /// IIFAA分配的业务场景CODE
        /// </summary>
        [XmlElement("scene_code")]
        public string SceneCode { get; set; }

        /// <summary>
        /// 券商名称
        /// </summary>
        [XmlElement("stock_name")]
        public string StockName { get; set; }

        /// <summary>
        /// 用户唯一交易ID
        /// </summary>
        [XmlElement("user_trans_id")]
        public string UserTransId { get; set; }
    }
}
