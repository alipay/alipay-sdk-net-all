using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayOpenIotvspOrguserCreateModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenIotvspOrguserCreateModel : AopObject
    {
        /// <summary>
        /// 授权的appId
        /// </summary>
        [XmlElement("authorize_app_id")]
        public string AuthorizeAppId { get; set; }

        /// <summary>
        /// 授权appid的pid，不一定是isv本人的pid
        /// </summary>
        [XmlElement("authorize_app_pid")]
        public string AuthorizeAppPid { get; set; }

        /// <summary>
        /// 人员数据的流水ID，用于核身组件初始化参数
        /// </summary>
        [XmlElement("biz_id")]
        public string BizId { get; set; }

        /// <summary>
        /// 证件号码
        /// </summary>
        [XmlElement("cert_no")]
        public string CertNo { get; set; }

        /// <summary>
        /// 证件类型，IDENTITY_CARD身份证，PASS_PORT护照，STU_NUM学生学号，COMPANY_NUM工号，TAIWAN_CARD台胞证，HK_MC_CARD港澳证件
        /// </summary>
        [XmlElement("cert_type")]
        public string CertType { get; set; }

        /// <summary>
        /// 签约主体外标id
        /// </summary>
        [XmlElement("entity_id")]
        public string EntityId { get; set; }

        /// <summary>
        /// 签约主体类型，1机构2机构集，和签约主体id配合使用
        /// </summary>
        [XmlElement("entity_type")]
        public long EntityType { get; set; }

        /// <summary>
        /// 用户额外信息
        /// </summary>
        [XmlElement("ext")]
        public string Ext { get; set; }

        /// <summary>
        /// isv英文名称
        /// </summary>
        [XmlElement("isv_name")]
        public string IsvName { get; set; }

        /// <summary>
        /// 用户姓名
        /// </summary>
        [XmlElement("name")]
        public string Name { get; set; }
    }
}
