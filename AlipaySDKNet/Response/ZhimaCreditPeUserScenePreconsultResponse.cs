using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// ZhimaCreditPeUserScenePreconsultResponse.
    /// </summary>
    public class ZhimaCreditPeUserScenePreconsultResponse : AopResponse
    {
        /// <summary>
        /// 极速退开通标识true 开通 false 否
        /// </summary>
        [XmlElement("accessible")]
        public bool Accessible { get; set; }

        /// <summary>
        /// 剩余可用额度（场景维度，且只对特定场景开放）
        /// </summary>
        [XmlElement("available_amount")]
        public string AvailableAmount { get; set; }

        /// <summary>
        /// 剩余可用件数（场景维度，且只对特定场景开放）
        /// </summary>
        [XmlElement("available_goods_count")]
        public string AvailableGoodsCount { get; set; }

        /// <summary>
        /// 买家的蚂蚁统一会员ID
        /// </summary>
        [XmlElement("buyer_id")]
        public string BuyerId { get; set; }

        /// <summary>
        /// 芝麻预咨询单号
        /// </summary>
        [XmlElement("eval_invoke_id")]
        public string EvalInvokeId { get; set; }

        /// <summary>
        /// 场景等级 A,B ,C等,A B C D分别代表业务方不同的差异化服务
        /// </summary>
        [XmlElement("scene_level")]
        public string SceneLevel { get; set; }

        /// <summary>
        /// 人维度的封顶金额
        /// </summary>
        [XmlElement("top_amount")]
        public string TopAmount { get; set; }

        /// <summary>
        /// 人维度的封顶件数
        /// </summary>
        [XmlElement("top_goods_count")]
        public string TopGoodsCount { get; set; }
    }
}
