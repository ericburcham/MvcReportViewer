﻿using System.Collections.Generic;
using System.Web.Mvc;
using Microsoft.Reporting.WebForms;

namespace MvcReportViewer
{
    public static class ReportRunnerExtensions
    {
        public static FileStreamResult Report(this Controller controller, IProvideReportConfiguration configuration)
        {
            var reportRunner = new ReportRunner(configuration);
            return reportRunner.Run();
        }

        /// <summary>
        /// Creates a FileContentResult object by using Report Viewer Web Control.
        /// </summary>
        /// <param name="controller">The Controller instance that this method extends.</param>
        /// <param name="reportFormat">Report Viewer Web Control supported format (Excel, Word, PDF or Image)</param>
        /// <param name="reportPath">The path to the report on the server.</param>
        /// <param name="deviceInfo">An XML string that contains the device-specific content that is required by the rendering extension specified in the format parameter. For more information about device information settings for specific output formats, see fe718939-7efe-4c7f-87cb-5f5b09caeff4 Device Information Settings  in SQL Server Books Online.</param>
        /// <param name="mode">Report processing mode: remote or local.</param>
        /// <param name="localReportDataSources">Local report data sources</param>
        /// <param name="filename">Output filename</param>
        /// <returns>The file-content result object.</returns>
        public static FileStreamResult Report(
            this Controller controller, 
            ReportFormat reportFormat, 
            string reportPath,
            string deviceInfo = DefaultParameterValues.DeviceInfo,
            ProcessingMode mode = ProcessingMode.Remote,
            IDictionary<string, object> localReportDataSources = null,
            string filename = null)
        {
            var reportRunner = new ReportRunner(reportFormat, reportPath, deviceInfo, mode, localReportDataSources, filename);
            return reportRunner.Run();
        }

        /// <summary>
        /// Creates a FileContentResult object by using Report Viewer Web Control.
        /// </summary>
        /// <param name="controller">The Controller instance that this method extends.</param>
        /// <param name="reportFormat">Report Viewer Web Control supported format (Excel, Word, PDF or Image)</param>
        /// <param name="reportPath">The path to the report on the server.</param>
        /// <param name="reportParameters">The report parameter properties for the report.</param>
        /// <param name="deviceInfo">An XML string that contains the device-specific content that is required by the rendering extension specified in the format parameter. For more information about device information settings for specific output formats, see fe718939-7efe-4c7f-87cb-5f5b09caeff4 Device Information Settings  in SQL Server Books Online.</param>
        /// <param name="mode">Report processing mode: remote or local.</param>
        /// <param name="localReportDataSources">Local report data sources</param>
        /// <param name="filename">Output filename</param>
        /// <returns>The file-content result object.</returns>
        public static FileStreamResult Report(
            this Controller controller,
            ReportFormat reportFormat,
            string reportPath,
            object reportParameters,
            string deviceInfo = DefaultParameterValues.DeviceInfo,
            ProcessingMode mode = ProcessingMode.Remote,
            IDictionary<string, object> localReportDataSources = null,
            string filename = null)
        {
            var reportRunner = new ReportRunner(
                reportFormat, 
                reportPath,
                HtmlHelper.AnonymousObjectToHtmlAttributes(reportParameters),
                deviceInfo,
                mode,
                localReportDataSources,
                filename);

            return reportRunner.Run();
        }

        /// <summary>
        /// Creates a FileContentResult object by using Report Viewer Web Control.
        /// </summary>
        /// <param name="controller">The Controller instance that this method extends.</param>
        /// <param name="reportFormat">Report Viewer Web Control supported format (Excel, Word, PDF or Image)</param>
        /// <param name="reportPath">The path to the report on the server.</param>
        /// <param name="reportParameters">The report parameter properties for the report.</param>
        /// <param name="deviceInfo">An XML string that contains the device-specific content that is required by the rendering extension specified in the format parameter. For more information about device information settings for specific output formats, see fe718939-7efe-4c7f-87cb-5f5b09caeff4 Device Information Settings  in SQL Server Books Online.</param>
        /// <param name="mode">Report processing mode: remote or local.</param>
        /// <param name="localReportDataSources">Local report data sources</param>
        /// <param name="filename">Output filename</param>
        /// <returns>The file-content result object.</returns>
        public static FileStreamResult Report(
            this Controller controller,
            ReportFormat reportFormat,
            string reportPath,
            IEnumerable<KeyValuePair<string, object>> reportParameters,
            string deviceInfo = DefaultParameterValues.DeviceInfo,
            ProcessingMode mode = ProcessingMode.Remote,
            IDictionary<string, object> localReportDataSources = null,
            string filename = null)
        {
            var reportRunner = new ReportRunner(
                reportFormat,
                reportPath,
                reportParameters,
                deviceInfo,
                mode,
                localReportDataSources,
                filename);

            return reportRunner.Run();
        }

        /// <summary>
        /// Creates a FileContentResult object by using Report Viewer Web Control.
        /// </summary>
        /// <param name="controller">The Controller instance that this method extends.</param>
        /// <param name="reportFormat">Report Viewer Web Control supported format (Excel, Word, PDF or Image)</param>
        /// <param name="reportPath">The path to the report on the server.</param>
        /// <param name="reportServerUrl">The URL for the report server.</param>
        /// <param name="username">The report server username.</param>
        /// <param name="password">The report server password.</param>
        /// <param name="reportParameters">The report parameter properties for the report.</param>
        /// <param name="deviceInfo">An XML string that contains the device-specific content that is required by the rendering extension specified in the format parameter. For more information about device information settings for specific output formats, see fe718939-7efe-4c7f-87cb-5f5b09caeff4 Device Information Settings  in SQL Server Books Online.</param>
        /// <param name="mode">Report processing mode: remote or local.</param>
        /// <param name="localReportDataSources">Local report data sources</param>
        /// <param name="filename">Output filename</param>
        /// <returns>The file-content result object.</returns>
        public static FileStreamResult Report(
            this Controller controller,
            ReportFormat reportFormat,
            string reportPath,
            string reportServerUrl,
            string username = null,
            string password = null,
            object reportParameters = null,
            string deviceInfo = DefaultParameterValues.DeviceInfo,
            ProcessingMode mode = ProcessingMode.Remote,
            IDictionary<string, object> localReportDataSources = null,
            string filename = null)
        {
            var reportRunner = new ReportRunner(
                reportFormat,
                reportPath,
                reportServerUrl,
                username,
                password,
                HtmlHelper.AnonymousObjectToHtmlAttributes(reportParameters),
                deviceInfo,
                mode,
                localReportDataSources,
                filename);

            return reportRunner.Run();
        }

        /// <summary>
        /// Creates a FileContentResult object by using Report Viewer Web Control.
        /// </summary>
        /// <param name="controller">The Controller instance that this method extends.</param>
        /// <param name="reportFormat">Report Viewer Web Control supported format (Excel, Word, PDF or Image)</param>
        /// <param name="reportPath">The path to the report on the server.</param>
        /// <param name="reportServerUrl">The URL for the report server.</param>
        /// <param name="reportParameters">The report parameter properties for the report.</param>
        /// <param name="username">The report server username.</param>
        /// <param name="password">The report server password.</param>
        /// <param name="deviceInfo">An XML string that contains the device-specific content that is required by the rendering extension specified in the format parameter. For more information about device information settings for specific output formats, see fe718939-7efe-4c7f-87cb-5f5b09caeff4 Device Information Settings  in SQL Server Books Online.</param>
        /// <param name="mode">Report processing mode: remote or local.</param>
        /// <param name="localReportDataSources">Local report data sources</param>
        /// <param name="filename">Output filename</param>
        /// <returns>The file-content result object.</returns>
        public static FileStreamResult Report(
            this Controller controller,
            ReportFormat reportFormat,
            string reportPath,
            string reportServerUrl,
            IEnumerable<KeyValuePair<string, object>> reportParameters,
            string username = null,
            string password = null,
            string deviceInfo = DefaultParameterValues.DeviceInfo,
            ProcessingMode mode = ProcessingMode.Remote,
            IDictionary<string, object> localReportDataSources = null,
            string filename = null)
        {
            var reportRunner = new ReportRunner(
                reportFormat,
                reportPath,
                reportServerUrl,
                username,
                password,
                reportParameters,
                deviceInfo,
                mode,
                localReportDataSources,
                filename);

            return reportRunner.Run();
        }
    }
}
