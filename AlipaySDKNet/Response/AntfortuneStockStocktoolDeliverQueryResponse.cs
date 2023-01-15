using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AntfortuneStockStocktoolDeliverQueryResponse.
    /// </summary>
    public class AntfortuneStockStocktoolDeliverQueryResponse : AopResponse
    {
        /// <summary>
        /// 蚂蚁统一会员ID
        /// </summary>
        [XmlElement("open_id")]
        public string OpenId { get; set; }

        /// <summary>
        /// 展位准入列表
        /// </summary>
        [XmlArray("position_list")]
        [XmlArrayItem("stock_position_v_o")]
        public List<StockPositionVO> PositionList { get; set; }

        /// <summary>
        /// 蚂蚁统一会员ID
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }
    }
}
