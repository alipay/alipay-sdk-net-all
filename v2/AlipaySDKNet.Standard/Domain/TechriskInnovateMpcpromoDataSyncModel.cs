using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// TechriskInnovateMpcpromoDataSyncModel Data Structure.
    /// </summary>
    [Serializable]
    public class TechriskInnovateMpcpromoDataSyncModel : AopObject
    {
        /// <summary>
        /// 商品数据的列表
        /// </summary>
        [XmlArray("data_list")]
        [XmlArrayItem("mpcpromo_goods_list")]
        public List<MpcpromoGoodsList> DataList { get; set; }

        /// <summary>
        /// 数据类型 : SHOP（店铺数据）、VOUCHER（商家券数据）、ITEM（商品数据）
        /// </summary>
        [XmlElement("data_type")]
        public string DataType { get; set; }

        /// <summary>
        /// 行业类别:   goodsLease（常规/租赁 商品数据）,voucherNormal（常规商家券）,shopNormal（店铺数据）
        /// </summary>
        [XmlElement("industry")]
        public string Industry { get; set; }

        /// <summary>
        /// 店铺数据
        /// </summary>
        [XmlArray("shop_list")]
        [XmlArrayItem("mpcpromo_shop_list")]
        public List<MpcpromoShopList> ShopList { get; set; }

        /// <summary>
        /// 商家券数据
        /// </summary>
        [XmlArray("voucher_list")]
        [XmlArrayItem("mpcpromo_voucher_list")]
        public List<MpcpromoVoucherList> VoucherList { get; set; }
    }
}
