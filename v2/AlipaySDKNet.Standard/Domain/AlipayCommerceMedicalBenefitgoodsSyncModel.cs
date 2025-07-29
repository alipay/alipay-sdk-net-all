using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceMedicalBenefitgoodsSyncModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceMedicalBenefitgoodsSyncModel : AopObject
    {
        /// <summary>
        /// 权益品的新增-CREATE、更新-UPDATE、下架操作-OFFLINE、上架操作-ONLINE
        /// </summary>
        [XmlElement("operate_type")]
        public string OperateType { get; set; }

        /// <summary>
        /// 产品详情信息
        /// </summary>
        [XmlElement("product")]
        public BenefitGoodDetail Product { get; set; }
    }
}
