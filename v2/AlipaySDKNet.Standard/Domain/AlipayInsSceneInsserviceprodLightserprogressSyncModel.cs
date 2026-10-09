using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayInsSceneInsserviceprodLightserprogressSyncModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayInsSceneInsserviceprodLightserprogressSyncModel : AopObject
    {
        /// <summary>
        /// 扩展字段
        /// </summary>
        [XmlElement("biz_data")]
        public string BizData { get; set; }

        /// <summary>
        /// 用于在蚂蚁侧执行跳转逻辑
        /// </summary>
        [XmlElement("inst_action_url")]
        public string InstActionUrl { get; set; }

        /// <summary>
        /// 服务的一次使用订单编号
        /// </summary>
        [XmlElement("inst_apply_order_no")]
        public string InstApplyOrderNo { get; set; }

        /// <summary>
        /// 机构订单服务进度节点编码
        /// </summary>
        [XmlElement("inst_node_code")]
        public string InstNodeCode { get; set; }

        /// <summary>
        /// 机构保单号
        /// </summary>
        [XmlElement("inst_policy_no")]
        public string InstPolicyNo { get; set; }

        /// <summary>
        /// 用于区别不用的服务产品，此字段为机构在商家平台发布商品时填写的外部商品码。
        /// </summary>
        [XmlElement("inst_prod_item_no")]
        public string InstProdItemNo { get; set; }

        /// <summary>
        /// 订单的服务进度流程编号，用来表示一次订单中，某一个节点的编号。
        /// </summary>
        [XmlElement("inst_progress_no")]
        public string InstProgressNo { get; set; }

        /// <summary>
        /// 服务订单创建时间
        /// </summary>
        [XmlElement("order_create_time")]
        public string OrderCreateTime { get; set; }

        /// <summary>
        /// 订单该进度节点的创建时间
        /// </summary>
        [XmlElement("progress_create_time")]
        public string ProgressCreateTime { get; set; }
    }
}
