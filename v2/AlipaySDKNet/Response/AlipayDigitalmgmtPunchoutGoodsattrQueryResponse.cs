using System;
using System.Xml.Serialization;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayDigitalmgmtPunchoutGoodsattrQueryResponse.
    /// </summary>
    public class AlipayDigitalmgmtPunchoutGoodsattrQueryResponse : AopResponse
    {
        /// <summary>
        /// 当前查询的是第几页，如1 则是第1页
        /// </summary>
        [XmlElement("page_num")]
        public long PageNum { get; set; }

        /// <summary>
        /// 每页返回数据的大小，数据来自入参
        /// </summary>
        [XmlElement("page_size")]
        public long PageSize { get; set; }

        /// <summary>
        /// 商品规格报价价格
        /// </summary>
        [XmlElement("price_list")]
        public MallGoodsPrice PriceList { get; set; }

        /// <summary>
        /// 返回100代表 一共有100条数据
        /// </summary>
        [XmlElement("total")]
        public long Total { get; set; }
    }
}
