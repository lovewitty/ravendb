﻿using System;

namespace Raven.Database.Server.Connections
{
	public interface IEventsTransport : IDisposable
	{
		string Id { get; }
		bool Connected { get; set; }
        long CoolDownWithDataLossInMiliseconds { get; set; }

		event Action Disconnected;
		void SendAsync(object msg);
	}
}
