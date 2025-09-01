using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// RentAftersaleOperationRecordVO Data Structure.
    /// </summary>
    [Serializable]
    public class RentAftersaleOperationRecordVO : AopObject
    {
        /// <summary>
        /// 申请售后的补充描述
        /// </summary>
        [XmlElement("additional_description")]
        public string AdditionalDescription { get; set; }

        /// <summary>
        /// 用户申请售后的补充凭证，类型包括图片、视频等
        /// </summary>
        [XmlArray("additional_media_list")]
        [XmlArrayItem("rent_aftersale_media_info_v_o")]
        public List<RentAftersaleMediaInfoVO> AdditionalMediaList { get; set; }

        /// <summary>
        /// 费用信息
        /// </summary>
        [XmlElement("fund_info")]
        public RentAftersaleFundInfoVO FundInfo { get; set; }

        /// <summary>
        /// 商户下一步可操作类型列表
        /// </summary>
        [XmlArray("next_operation_type_list")]
        [XmlArrayItem("string")]
        public List<string> NextOperationTypeList { get; set; }

        /// <summary>
        /// 商户操作的截止时间
        /// </summary>
        [XmlElement("operation_deadline")]
        public string OperationDeadline { get; set; }

        /// <summary>
        /// 操作时间
        /// </summary>
        [XmlElement("operation_time")]
        public string OperationTime { get; set; }

        /// <summary>
        /// 操作类型
        /// </summary>
        [XmlElement("operation_type")]
        public string OperationType { get; set; }

        /// <summary>
        /// 申请售后的原因
        /// </summary>
        [XmlElement("reason_description")]
        public string ReasonDescription { get; set; }
    }
}
