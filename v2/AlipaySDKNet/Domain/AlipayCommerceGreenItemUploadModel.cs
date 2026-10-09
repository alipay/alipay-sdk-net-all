using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceGreenItemUploadModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceGreenItemUploadModel : AopObject
    {
        /// <summary>
        /// 能量码归属的商户信息, 说明：  (1)如果该复杂对象不填，根据openAPI标准流程决定能量码归属方  -商户自研, 那么能量码归属方就是该商户.   -第三方应用授权, 那么能量码归属方就是授权的商户. 参考https://opendocs.alipay.com/isv/10467/xldcyq  (2)如果填写，则认为能量码归属方就是merchant_pid对应的商户.
        /// </summary>
        [XmlElement("belong_merchant_info")]
        public BelongGreenMerchantInfo BelongMerchantInfo { get; set; }

        /// <summary>
        /// 指定数据上传操作类型，1: 插入，2: 删除
        /// </summary>
        [XmlElement("data_operation")]
        public long DataOperation { get; set; }

        /// <summary>
        /// 商品69码
        /// </summary>
        [XmlElement("goods_id")]
        public string GoodsId { get; set; }

        /// <summary>
        /// 商品名称，当data_operation传入1的时候必填
        /// </summary>
        [XmlElement("goods_name")]
        public string GoodsName { get; set; }

        /// <summary>
        /// 能量码列表，格式由商户自定义上传，最多不能超过100条。
        /// </summary>
        [XmlArray("qr_code_list")]
        [XmlArrayItem("string")]
        public List<string> QrCodeList { get; set; }

        /// <summary>
        /// 数据上传时间。标准时间格式：yyyy-MM-dd HH:mm:ss
        /// </summary>
        [XmlElement("upload_time")]
        public string UploadTime { get; set; }
    }
}
