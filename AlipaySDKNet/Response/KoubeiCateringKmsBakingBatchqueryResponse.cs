using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// KoubeiCateringKmsBakingBatchqueryResponse.
    /// </summary>
    public class KoubeiCateringKmsBakingBatchqueryResponse : AopResponse
    {
        /// <summary>
        /// 烘焙商品销量预测
        /// </summary>
        [XmlArray("baking_sales_forecast_data")]
        [XmlArrayItem("kms_baking_sales_forecast_d_t_o")]
        public List<KmsBakingSalesForecastDTO> BakingSalesForecastData { get; set; }
    }
}
