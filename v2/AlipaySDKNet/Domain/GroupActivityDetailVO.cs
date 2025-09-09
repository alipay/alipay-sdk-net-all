using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// GroupActivityDetailVO Data Structure.
    /// </summary>
    [Serializable]
    public class GroupActivityDetailVO : AopObject
    {
        /// <summary>
        /// 业务类型
        /// </summary>
        [XmlElement("biz_type")]
        public string BizType { get; set; }

        /// <summary>
        /// 展位位置 群福利(group_welfare),热门推荐(hot_recommend),群内消息卡片(group_msg_card)
        /// </summary>
        [XmlElement("client_position")]
        public string ClientPosition { get; set; }

        /// <summary>
        /// 优惠群活动顶部运营位内容
        /// </summary>
        [XmlElement("coupon_content")]
        public CouponActivityContentVO CouponContent { get; set; }

        /// <summary>
        /// 自定义活动顶部运营位内容
        /// </summary>
        [XmlElement("custom_content")]
        public CustomActivityContentVO CustomContent { get; set; }

        /// <summary>
        /// 活动截止时间
        /// </summary>
        [XmlElement("gmt_end")]
        public string GmtEnd { get; set; }

        /// <summary>
        /// 活动开始时间
        /// </summary>
        [XmlElement("gmt_start")]
        public string GmtStart { get; set; }

        /// <summary>
        /// 商品活动顶部运营位内容
        /// </summary>
        [XmlElement("goods_content")]
        public GoodsActivityContentVO GoodsContent { get; set; }

        /// <summary>
        /// 商家群活动id
        /// </summary>
        [XmlElement("group_activity_id")]
        public string GroupActivityId { get; set; }

        /// <summary>
        /// 群组id列表，创建群组时对应的一个群组id
        /// </summary>
        [XmlArray("group_ids")]
        [XmlArrayItem("string")]
        public List<string> GroupIds { get; set; }

        /// <summary>
        /// 展示优先级 1-5, 数字越大优先级越高
        /// </summary>
        [XmlElement("priority")]
        public long Priority { get; set; }

        /// <summary>
        /// 商家群活动状态 INIT(初始化), CC_AUDITING(安全审核中), CC(安全审核驳回), PENDING(待生效), VALID(生效), SUSPEND(暂停), STOPPED(结束)
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }
    }
}
