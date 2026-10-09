using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ZhimaCreditEpCreditlinkloanDataSaveModel Data Structure.
    /// </summary>
    [Serializable]
    public class ZhimaCreditEpCreditlinkloanDataSaveModel : AopObject
    {
        /// <summary>
        /// 需要存储的数据内容，是JSON结构，其内容和collect_data_type 相对应，例如{"frontPhotoFileId":"A","reversePhotoFileId":"B","facePhotoFileId":"C"}
        /// </summary>
        [XmlElement("collect_data_content")]
        public string CollectDataContent { get; set; }

        /// <summary>
        /// 保存的数据类型
        /// </summary>
        [XmlElement("collect_data_type")]
        public string CollectDataType { get; set; }

        /// <summary>
        /// 商户自身的单号，需保证其唯一性
        /// </summary>
        [XmlElement("merchant_biz_no")]
        public string MerchantBizNo { get; set; }

        /// <summary>
        /// 订单类型
        /// </summary>
        [XmlElement("order_type")]
        public string OrderType { get; set; }
    }
}
