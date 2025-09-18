using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayDataDataserviceNgfeTagSetModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayDataDataserviceNgfeTagSetModel : AopObject
    {
        /// <summary>
        /// 标签写入应用，用于鉴权, 业务方按实际填写
        /// </summary>
        [XmlElement("app_name")]
        public string AppName { get; set; }

        /// <summary>
        /// 如线下支付交易单号
        /// </summary>
        [XmlElement("idempotent_id")]
        public string IdempotentId { get; set; }

        /// <summary>
        /// 一级域名称，固定传NgfeL1Domain
        /// </summary>
        [XmlElement("l_1_domain_code")]
        public string L1DomainCode { get; set; }

        /// <summary>
        /// 二级域名称，固定传NgfeL1DomainL2
        /// </summary>
        [XmlElement("l_2_domain_code")]
        public string L2DomainCode { get; set; }

        /// <summary>
        /// 用于传入标签更新的扩展信息，例如传入二维实体ID。 key："slave_objId", value:"xxx"
        /// </summary>
        [XmlArray("label_update_ext_info_list")]
        [XmlArrayItem("label_update_ext_info")]
        public List<LabelUpdateExtInfo> LabelUpdateExtInfoList { get; set; }

        /// <summary>
        /// 待更新的标签列表
        /// </summary>
        [XmlArray("label_update_model_list")]
        [XmlArrayItem("label_update_detail")]
        public List<LabelUpdateDetail> LabelUpdateModelList { get; set; }

        /// <summary>
        /// 标签实体ID
        /// </summary>
        [XmlElement("object_id")]
        public string ObjectId { get; set; }

        /// <summary>
        /// 标签实体ID
        /// </summary>
        [XmlElement("object_open_id")]
        public string ObjectOpenId { get; set; }

        /// <summary>
        /// 用于流量统计
        /// </summary>
        [XmlElement("scene")]
        public string Scene { get; set; }

        /// <summary>
        /// 用于标识通过哪个渠道写入的标签
        /// </summary>
        [XmlElement("source")]
        public string Source { get; set; }
    }
}
