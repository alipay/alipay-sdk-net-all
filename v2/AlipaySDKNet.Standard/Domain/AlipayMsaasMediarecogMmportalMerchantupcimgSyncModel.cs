using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayMsaasMediarecogMmportalMerchantupcimgSyncModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayMsaasMediarecogMmportalMerchantupcimgSyncModel : AopObject
    {
        /// <summary>
        /// 行业同步的商家upc图片表结果入参
        /// </summary>
        [XmlArray("list")]
        [XmlArrayItem("merchant_upc_img_request_vo")]
        public List<MerchantUpcImgRequestVo> List { get; set; }
    }
}
