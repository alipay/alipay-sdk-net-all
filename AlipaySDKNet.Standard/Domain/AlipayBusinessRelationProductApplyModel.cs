using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayBusinessRelationProductApplyModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayBusinessRelationProductApplyModel : AopObject
    {
        /// <summary>
        /// 申请目标信息
        /// </summary>
        [XmlElement("apply_target_info")]
        public BusinessRelationApplyTargetInfo ApplyTargetInfo { get; set; }

        /// <summary>
        /// 附件信息，当产品码为门店经营分析数据产品码时，此项必填
        /// </summary>
        [XmlElement("attachment_info")]
        public BusinessRelationAttachmentInfo AttachmentInfo { get; set; }

        /// <summary>
        /// 内部业务编号,当operation_type为更新操作时，此项必填
        /// </summary>
        [XmlElement("biz_no")]
        public string BizNo { get; set; }

        /// <summary>
        /// 商业关系id，如：商圈mallid
        /// </summary>
        [XmlElement("group_id")]
        public string GroupId { get; set; }

        /// <summary>
        /// 商业关系组织子类型 定向参数 需找对应BD申请
        /// </summary>
        [XmlElement("group_sub_type")]
        public string GroupSubType { get; set; }

        /// <summary>
        /// 商业关系组织类型 定向参数 需找对应BD申请
        /// </summary>
        [XmlElement("group_type")]
        public string GroupType { get; set; }

        /// <summary>
        /// 操作类型，CREAE:创建，UPDATE:更新
        /// </summary>
        [XmlElement("operation_type")]
        public string OperationType { get; set; }

        /// <summary>
        /// 外部业务号
        /// </summary>
        [XmlElement("out_biz_no")]
        public string OutBizNo { get; set; }

        /// <summary>
        /// 产品码，标识具体的产品能力，门店经营数据产品码：SHOP_TRADE_ANALYSIS_DATA
        /// </summary>
        [XmlElement("product_code")]
        public string ProductCode { get; set; }
    }
}
