using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// RentOrderExtendInfoVO Data Structure.
    /// </summary>
    [Serializable]
    public class RentOrderExtendInfoVO : AopObject
    {
        /// <summary>
        /// 当前订单用户是否授权静默签署电子合同
        /// </summary>
        [XmlElement("ec_sign_user_authorized")]
        public string EcSignUserAuthorized { get; set; }

        /// <summary>
        /// 已上传电子合同
        /// </summary>
        [XmlArray("merchant_upload_contracts")]
        [XmlArrayItem("rent_merchant_upload_contract_v_o")]
        public List<RentMerchantUploadContractVO> MerchantUploadContracts { get; set; }

        /// <summary>
        /// 承诺发货时间
        /// </summary>
        [XmlElement("promised_send_time")]
        public string PromisedSendTime { get; set; }

        /// <summary>
        /// 回收订单ID
        /// </summary>
        [XmlElement("recycle_order_id")]
        public string RecycleOrderId { get; set; }

        /// <summary>
        /// 租赁派单ID，唯一标识一次派单请求
        /// </summary>
        [XmlElement("rent_dispatch_id")]
        public string RentDispatchId { get; set; }

        /// <summary>
        /// 定义参考 <a href="https://opendocs.alipay.com/mini/0dfcde" target="_blank">公域场景标识</a>
        /// </summary>
        [XmlElement("scene_id")]
        public string SceneId { get; set; }

        /// <summary>
        /// 芝麻租赁频道联营订单标
        /// </summary>
        [XmlElement("union_rent_tag")]
        public string UnionRentTag { get; set; }
    }
}
