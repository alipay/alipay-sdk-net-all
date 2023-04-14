using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ServicePromoBaseVO Data Structure.
    /// </summary>
    [Serializable]
    public class ServicePromoBaseVO : AopObject
    {
        /// <summary>
        /// 状态；枚举值如下：  CREATE_AUDITING("CREATE_AUDITING", "新增审核中"),     EDIT_AUDITING("EDIT_AUDITING", "修改审核中"),     AUDITED("AUDITED", "审核通过"),     CREATE_AUDIT_REJECT("CREATE_AUDIT_REJECT", "新增驳回"),     EDIT_AUDIT_REJECT("EDIT_AUDIT_REJECT", "修改驳回"),     DELETED("DELETED", "已删除");
        /// </summary>
        [XmlElement("biz_status")]
        public string BizStatus { get; set; }

        /// <summary>
        /// 展台ID
        /// </summary>
        [XmlElement("promo_booth_id")]
        public string PromoBoothId { get; set; }

        /// <summary>
        /// 内容列表
        /// </summary>
        [XmlArray("promo_contents")]
        [XmlArrayItem("promo_content_biz_v_o")]
        public List<PromoContentBizVO> PromoContents { get; set; }

        /// <summary>
        /// 实体的编码列表
        /// </summary>
        [XmlArray("promo_entity_codes")]
        [XmlArrayItem("string")]
        public List<string> PromoEntityCodes { get; set; }

        /// <summary>
        /// 实体类型。枚举值如下： MINI_APP("MINI_APP", "小程序"), STD_SERVICE("STD_SERVICE", "标准化服务"), SERVICE_BACK_CATALOG("SERVICE_BACK_CATALOG", "服务类目")
        /// </summary>
        [XmlElement("promo_entity_type")]
        public string PromoEntityType { get; set; }

        /// <summary>
        /// 服务场景素材记录ID
        /// </summary>
        [XmlElement("promo_record_id")]
        public string PromoRecordId { get; set; }

        /// <summary>
        /// 驳回理由
        /// </summary>
        [XmlElement("reject_reason")]
        public string RejectReason { get; set; }
    }
}
