using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// RentDeductInfoDTO Data Structure.
    /// </summary>
    [Serializable]
    public class RentDeductInfoDTO : AopObject
    {
        /// <summary>
        /// 代扣服务名称。用于在代扣协议详情中展示，方便用户区分该笔代扣对应的订单，建议传入标准的商品名称
        /// </summary>
        [XmlElement("service_name")]
        public string ServiceName { get; set; }

        /// <summary>
        /// 代扣签约场景。租赁代扣固定传入RENT_DEDUCT
        /// </summary>
        [XmlElement("sign_scene")]
        public string SignScene { get; set; }
    }
}
