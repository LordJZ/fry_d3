﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using bnet.protocol.channel;
using d3.Network;

namespace d3.Server.Services {
	public class ChannelImpl: Channel {
		ClientHandler client;
		public ChannelImpl(ClientHandler client) {
			this.client = client;
		}

		public override void AddMember(Google.ProtocolBuffers.IRpcController controller, AddMemberRequest request, Action<bnet.protocol.NoData> done) {
			throw new NotImplementedException();
		}

		public override void RemoveMember(Google.ProtocolBuffers.IRpcController controller, RemoveMemberRequest request, Action<bnet.protocol.NoData> done) {
			throw new NotImplementedException();
		}

		public override void SendMessage(Google.ProtocolBuffers.IRpcController controller, SendMessageRequest request, Action<bnet.protocol.NoData> done) {
			throw new NotImplementedException();
		}

		public override void UpdateChannelState(Google.ProtocolBuffers.IRpcController controller, UpdateChannelStateRequest request, Action<bnet.protocol.NoData> done) {
			throw new NotImplementedException();
		}

		public override void UpdateMemberState(Google.ProtocolBuffers.IRpcController controller, UpdateMemberStateRequest request, Action<bnet.protocol.NoData> done) {
			throw new NotImplementedException();
		}

		public override void Dissolve(Google.ProtocolBuffers.IRpcController controller, DissolveRequest request, Action<bnet.protocol.NoData> done) {
			throw new NotImplementedException();
		}

		public override void SetRoles(Google.ProtocolBuffers.IRpcController controller, SetRolesRequest request, Action<bnet.protocol.NoData> done) {
			throw new NotImplementedException();
		}
	}
}
