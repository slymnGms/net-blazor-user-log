using System;
using BlazorUserRegLog.Models;

namespace BlazorUserRegLog.Services
{
    public class AlertService : IAlertService
    {
        private const string _defaultId = "deafult-alert";
        public event Action<Alert> onAlert;

        public void Alert(Alert alert)
        {
            alert.Id = alert.Id ?? _defaultId;
            this.onAlert?.Invoke(alert);
        }

        public void Clear(string id = null)
        {
            this.onAlert?.Invoke(new Alert { Id = id });
        }

        public void Error(string message, bool keepAfterRouteChange = false, bool autoClose = true)
        {
            this.Alert(new Alert
            {
                AutoClose = autoClose,
                Type = AlertType.Error,
                Message = message,
                KeepAfterRouteChange = keepAfterRouteChange
            });
        }

        public void Info(string message, bool keepAfterRouteChange = false, bool autoClose = true)
        {
            this.Alert(new Alert
            {
                AutoClose = autoClose,
                Type = AlertType.Info,
                Message = message,
                KeepAfterRouteChange = keepAfterRouteChange
            });
        }

        public void Success(string message, bool keepAfterRouteChange = false, bool autoClose = true)
        {
            this.Alert(new Alert
            {
                AutoClose = autoClose,
                Type = AlertType.Success,
                Message = message,
                KeepAfterRouteChange = keepAfterRouteChange
            });
        }

        public void Warn(string message, bool keepAfterRouteChange = false, bool autoClose = true)
        {
            this.Alert(new Alert
            {
                AutoClose = autoClose,
                Type = AlertType.Warning,
                Message = message,
                KeepAfterRouteChange = keepAfterRouteChange
            });
        }
    }
}