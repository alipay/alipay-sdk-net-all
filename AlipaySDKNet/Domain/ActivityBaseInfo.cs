using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ActivityBaseInfo Data Structure.
    /// </summary>
    [Serializable]
    public class ActivityBaseInfo : AopObject
    {
        /// <summary>
        /// 活动id
        /// </summary>
        [XmlElement("activity_id")]
        public string ActivityId { get; set; }

        /// <summary>
        /// 活动名称。 不对用户进行展示，仅供商家在后台管理活动使用。
        /// </summary>
        [XmlElement("activity_name")]
        public string ActivityName { get; set; }

        /// <summary>
        /// 活动操作状态。 取值范围： 1.CREATING：创建中。 2.MODIFYING：修改中。 3.APPENDING：追加中。 4.FINISHEING：终止中。 限制： 该值为空，说明活动当前没有正在执行中的操作。
        /// </summary>
        [XmlElement("activity_operation_status")]
        public string ActivityOperationStatus { get; set; }

        /// <summary>
        /// 活动状态。 取值范围： 1.ACTIVE：已激活（活动正常运行）。 2.FINISHED：已终止（商家终止活动，不可再发放。 限制： 1.该值为空，说明活动还未创建成功。可以使用 activity_operation_status字段判断活动是否处于CREATING状态。
        /// </summary>
        [XmlElement("activity_status")]
        public string ActivityStatus { get; set; }

        /// <summary>
        /// 商家券活动归属的商户信息。 说明： 如果该复杂对象不填。则默认为该商家券活动的归属者是调用者本人。 如果填写，则认为该商家券活动的归属者是该商户。 限制:自研商户可以不传，服务商身份接入时必传
        /// </summary>
        [XmlElement("belong_merchant_info")]
        public BelongMerchantInfo BelongMerchantInfo { get; set; }

        /// <summary>
        /// 码模式。 枚举值： MERCHANT_UPLOAD：商户上传自定义code，发券时系统随机选取上传的券code发放 MERCHANT_API：发奖时指定券码发奖，此模式无须提前上传券码。
        /// </summary>
        [XmlElement("code_mode")]
        public string CodeMode { get; set; }
    }
}
