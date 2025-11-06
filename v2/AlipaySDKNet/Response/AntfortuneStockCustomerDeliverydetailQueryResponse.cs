using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AntfortuneStockCustomerDeliverydetailQueryResponse.
    /// </summary>
    public class AntfortuneStockCustomerDeliverydetailQueryResponse : AopResponse
    {
        /// <summary>
        /// 签约协议号（uid在某个机构处的唯一标识）
        /// </summary>
        [XmlElement("agreement_no")]
        public string AgreementNo { get; set; }

        /// <summary>
        /// 用户投放展位内容数组
        /// </summary>
        [XmlElement("delivery_detail_position")]
        public DeliveryDetailPositionVO DeliveryDetailPosition { get; set; }

        /// <summary>
        /// 投放流水线配置，下发后消费方根据流水线配置就行处理
        /// </summary>
        [XmlArray("delivery_detail_position_pipeline_config")]
        [XmlArrayItem("delivery_detail_position_pipeline_config_v_o")]
        public List<DeliveryDetailPositionPipelineConfigVO> DeliveryDetailPositionPipelineConfig { get; set; }
    }
}
