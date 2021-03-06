﻿using System;
using System.Net.PeerToPeer;

namespace PNRPService
{
    public interface IPNRPService
    {
        CloudCollection GetAvailableClouds();
        PeerName CreatePeerName(string name, bool isSecured);
        PeerNameRegistration RegisterPeer(PeerName peerName, int port);
        PeerNameResolver ResolvePeerName(PeerName peerName);
        event EventHandler<ResolveCompletedEventArgs> ResolutionCompleted;
    }
}