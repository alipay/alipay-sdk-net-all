using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayBossProdAntlegalchainMultipartyApplyModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayBossProdAntlegalchainMultipartyApplyModel : AopObject
    {
        /// <summary>
        /// 申请人工号(内部buc工号)
        /// </summary>
        [XmlElement("apply_buc_user_no")]
        public string ApplyBucUserNo { get; set; }

        /// <summary>
        /// 关联业务数据编号
        /// </summary>
        [XmlElement("biz_code")]
        public string BizCode { get; set; }

        /// <summary>
        /// 关联业务名称
        /// </summary>
        [XmlElement("biz_name")]
        public string BizName { get; set; }

        /// <summary>
        /// 业务数据请求唯一标识
        /// </summary>
        [XmlElement("biz_unique_id")]
        public string BizUniqueId { get; set; }

        /// <summary>
        /// 所有签约方企业信息列表(支持多方签约, 任何一方支持多家公司主体)
        /// </summary>
        [XmlArray("corp_entity_multi_list")]
        [XmlArrayItem("corp_entity")]
        public List<CorpEntity> CorpEntityMultiList { get; set; }

        /// <summary>
        /// 签约发起方企业信息
        /// </summary>
        [XmlElement("init_corp_entity")]
        public CorpEntity InitCorpEntity { get; set; }

        /// <summary>
        /// 签约文件对象信息列表
        /// </summary>
        [XmlArray("notary_file_list")]
        [XmlArrayItem("notary_file_v_o")]
        public List<NotaryFileVO> NotaryFileList { get; set; }

        /// <summary>
        /// 请求来源系统英文名称
        /// </summary>
        [XmlElement("request_app_name")]
        public string RequestAppName { get; set; }

        /// <summary>
        /// 请求时间戳（请求时间的毫秒值）
        /// </summary>
        [XmlElement("request_time_stamp")]
        public string RequestTimeStamp { get; set; }

        /// <summary>
        /// 请求token
        /// </summary>
        [XmlElement("request_token")]
        public string RequestToken { get; set; }

        /// <summary>
        /// 签约顺序类型 (值为IN_ORDER: 有顺序; 值为NON_ORDER: 无顺序)；默认为“有顺序”
        /// </summary>
        [XmlElement("sign_order_type")]
        public string SignOrderType { get; set; }

        /// <summary>
        /// 发起签约时间/我方签约时间
        /// </summary>
        [XmlElement("submit_time")]
        public string SubmitTime { get; set; }
    }
}
