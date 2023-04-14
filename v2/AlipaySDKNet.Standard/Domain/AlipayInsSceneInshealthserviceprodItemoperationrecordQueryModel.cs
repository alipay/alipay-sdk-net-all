using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayInsSceneInshealthserviceprodItemoperationrecordQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayInsSceneInshealthserviceprodItemoperationrecordQueryModel : AopObject
    {
        /// <summary>
        /// 支付宝的服务产品编号
        /// </summary>
        [XmlElement("ant_ser_prod_no")]
        public string AntSerProdNo { get; set; }

        /// <summary>
        /// 触发时间 end
        /// </summary>
        [XmlElement("init_time_end")]
        public string InitTimeEnd { get; set; }

        /// <summary>
        /// 触发时间 start
        /// </summary>
        [XmlElement("init_time_start")]
        public string InitTimeStart { get; set; }

        /// <summary>
        /// 机构商品编码
        /// </summary>
        [XmlElement("merchant_item_code")]
        public string MerchantItemCode { get; set; }

        /// <summary>
        /// 页码，默认为 1
        /// </summary>
        [XmlElement("page_no")]
        public long PageNo { get; set; }

        /// <summary>
        /// 页面大小，默认为10
        /// </summary>
        [XmlElement("page_size")]
        public long PageSize { get; set; }

        /// <summary>
        /// 药品操作类型列表。MAJOR 主要信息;EXT 扩展信息;UP 上架;DOWN 下架商品
        /// </summary>
        [XmlArray("refresh_type_list")]
        [XmlArrayItem("string")]
        public List<string> RefreshTypeList { get; set; }

        /// <summary>
        /// 状态列表。 PROCESSING  执行中， SUCCESS 成功， FAIL 执行失败
        /// </summary>
        [XmlArray("status_list")]
        [XmlArrayItem("string")]
        public List<string> StatusList { get; set; }
    }
}
