using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayOpenLotterymallExchangerecordstatusSyncModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenLotterymallExchangerecordstatusSyncModel : AopObject
    {
        /// <summary>
        /// 环境信息，PRE预发环境，PROD线上
        /// </summary>
        [XmlElement("env")]
        public string Env { get; set; }

        /// <summary>
        /// json格式的数据
        /// </summary>
        [XmlElement("extinfo")]
        public string Extinfo { get; set; }

        /// <summary>
        /// 积分兑换商城的兑换记录id
        /// </summary>
        [XmlElement("mallexchangerecordid")]
        public string Mallexchangerecordid { get; set; }

        /// <summary>
        /// 该笔订单之前的状态
        /// </summary>
        [XmlElement("now")]
        public string Now { get; set; }

        /// <summary>
        /// 调用方自己创建的订单id，为抽奖调用业务方下单时业务方生成的业务id
        /// </summary>
        [XmlElement("outbizid")]
        public string Outbizid { get; set; }

        /// <summary>
        /// 兑换记录目标状态
        /// </summary>
        [XmlElement("target")]
        public string Target { get; set; }
    }
}
