using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayInsSceneInsserviceprodServiceApplyModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayInsSceneInsserviceprodServiceApplyModel : AopObject
    {
        /// <summary>
        /// 蚂蚁的服务合约编号，通知蚂蚁生成服务订单时，需指定为哪个合约号生成订单
        /// </summary>
        [XmlElement("ant_contract_no")]
        public string AntContractNo { get; set; }

        /// <summary>
        /// 服务订单类型；枚举（ISSUE，USE，REFUND，SURRENDER）
        /// </summary>
        [XmlElement("apply_order_type")]
        public string ApplyOrderType { get; set; }

        /// <summary>
        /// 本字段是一个String类型的JSON，用于机构通知蚂蚁生成服务订单时，传入额外参数
        /// </summary>
        [XmlElement("biz_data")]
        public string BizData { get; set; }

        /// <summary>
        /// 机构侧创建此订单的时间
        /// </summary>
        [XmlElement("create_time")]
        public string CreateTime { get; set; }

        /// <summary>
        /// 外部业务号，服务商的服务订单号（幂等key）
        /// </summary>
        [XmlElement("out_biz_no")]
        public string OutBizNo { get; set; }
    }
}
