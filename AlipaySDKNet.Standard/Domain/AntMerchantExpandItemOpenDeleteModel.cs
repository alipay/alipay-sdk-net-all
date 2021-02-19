using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AntMerchantExpandItemOpenDeleteModel Data Structure.
    /// </summary>
    [Serializable]
    public class AntMerchantExpandItemOpenDeleteModel : AopObject
    {
        /// <summary>
        /// 商品ID，通过创建商品接口 https://opendocs.alipay.com/apis/api_4/ant.merchant.expand.item.open.create 获取。
        /// </summary>
        [XmlElement("item_id")]
        public string ItemId { get; set; }
    }
}
