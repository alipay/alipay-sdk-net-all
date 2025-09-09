using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommercePetinsureQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommercePetinsureQueryModel : AopObject
    {
        /// <summary>
        /// 外部业务单号，每一笔新的投保请求应该保持唯一。
        /// </summary>
        [XmlElement("biz_id")]
        public string BizId { get; set; }

        /// <summary>
        /// 查询保单的来源场景，为空默认为默认场景
        /// </summary>
        [XmlElement("biz_scene")]
        public string BizScene { get; set; }

        /// <summary>
        /// 买家用户Id
        /// </summary>
        [XmlElement("buyer_id")]
        public string BuyerId { get; set; }

        /// <summary>
        /// 买家openId
        /// </summary>
        [XmlElement("buyer_open_id")]
        public string BuyerOpenId { get; set; }

        /// <summary>
        /// 支付宝宠物Id
        /// </summary>
        [XmlElement("pet_id")]
        public string PetId { get; set; }
    }
}
