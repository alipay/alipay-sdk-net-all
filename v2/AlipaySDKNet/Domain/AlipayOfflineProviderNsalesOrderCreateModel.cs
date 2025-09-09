using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayOfflineProviderNsalesOrderCreateModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOfflineProviderNsalesOrderCreateModel : AopObject
    {
        /// <summary>
        /// 卖进后设备绑定需要的账号信息列表
        /// </summary>
        [XmlArray("device_record_files")]
        [XmlArrayItem("device_record_info")]
        public List<DeviceRecordInfo> DeviceRecordFiles { get; set; }

        /// <summary>
        /// 外部业务单号
        /// </summary>
        [XmlElement("out_biz_no")]
        public string OutBizNo { get; set; }

        /// <summary>
        /// 卖进扩展信息
        /// </summary>
        [XmlElement("sales_solution_ext")]
        public SalesSolutionExt SalesSolutionExt { get; set; }

        /// <summary>
        /// 卖进后对应的设备绑定场景
        /// </summary>
        [XmlElement("scene_code")]
        public string SceneCode { get; set; }

        /// <summary>
        /// 卖进方案id，必传
        /// </summary>
        [XmlElement("solution_id")]
        public string SolutionId { get; set; }

        /// <summary>
        /// 相对超时时间，取值范围：1m～15d。m-分钟，h-小时，d-天，1c-当天（1c-当天的情况下，无论订单何时创建，都在0点关闭），不允许传入小数。不传时默认值：30m。
        /// </summary>
        [XmlElement("timeout_express")]
        public string TimeoutExpress { get; set; }
    }
}
