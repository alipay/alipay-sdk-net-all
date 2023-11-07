using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceCardDetailQueryResponse.
    /// </summary>
    public class AlipayCommerceCardDetailQueryResponse : AopResponse
    {
        /// <summary>
        /// 取消类型
        /// </summary>
        [XmlElement("cancel_type")]
        public string CancelType { get; set; }

        /// <summary>
        /// 卡类型
        /// </summary>
        [XmlElement("card_type")]
        public string CardType { get; set; }

        /// <summary>
        /// 创建时间
        /// </summary>
        [XmlElement("create_date")]
        public string CreateDate { get; set; }

        /// <summary>
        /// 扣款计划
        /// </summary>
        [XmlArray("deduction_plan_response_list")]
        [XmlArrayItem("deduction_plan_response")]
        public List<DeductionPlanResponse> DeductionPlanResponseList { get; set; }

        /// <summary>
        /// 卡id
        /// </summary>
        [XmlElement("id")]
        public string Id { get; set; }

        /// <summary>
        /// 用户账号
        /// </summary>
        [XmlElement("login_id")]
        public string LoginId { get; set; }

        /// <summary>
        /// 商户名称
        /// </summary>
        [XmlElement("merchant_name")]
        public string MerchantName { get; set; }

        /// <summary>
        /// 自提卡名称
        /// </summary>
        [XmlElement("name")]
        public string Name { get; set; }

        /// <summary>
        /// 用户id
        /// </summary>
        [XmlElement("open_id")]
        public string OpenId { get; set; }

        /// <summary>
        /// 卡的orderId
        /// </summary>
        [XmlElement("order_id")]
        public string OrderId { get; set; }

        /// <summary>
        /// 卡剩余可用次数
        /// </summary>
        [XmlElement("remain_count")]
        public long RemainCount { get; set; }

        /// <summary>
        /// 商品id
        /// </summary>
        [XmlElement("spc_template_id")]
        public string SpcTemplateId { get; set; }

        /// <summary>
        /// 卡状态
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }

        /// <summary>
        /// 总计可使用次数
        /// </summary>
        [XmlElement("total_count")]
        public long TotalCount { get; set; }

        /// <summary>
        /// 用户id
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }
    }
}
