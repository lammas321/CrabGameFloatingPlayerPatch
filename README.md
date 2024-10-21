# CrabGameFloatingPlayerPatch
A small BepInEx mod for Crab Game that patches* the floating player issue.
This is a long read, but I recommend reading through it or at least reading the TLDR at the end to give players joining your lobbies the best experience.

Some time ago after an update to the way Steam handles Peer2Peer connections, Crab Game lobbies with around 15 players or more started seeing players just floating in place for the entirety of games, never moving or rotating, only punching and using items. The reason for this is whatever that Steam P2P update did made it more difficult to establish P2P connections with players, especially with those located further away or when the lobby has larger player counts

Most games will make clients send position and rotation data to the host for the host to verify, and then the host will either forward that information to all clients or block it if the data seems illegitimate or cheated, which is why server side anti cheats work. The problem with Crab Game is that this position and rotation isn't sent to the host and then to all players, rather it is sent directly from client to client with no host to verify it as the middle man. This technically means cheaters can lie to the host about their position to seem legit, and then use movement cheats and fling other players out the map without the host knowing who is doing it and I hate it, but that's getting off topic haha

Because of this method of sharing player position and rotation data, and with players not being able to establish connections with each other due to the Steam P2P update, player position and rotation packets never reach each other, thus resulting in players floating indefinitely until a connection is randomly established. Some may ask the question: "Why does the server host never see any floating players?" and that's because a connection had to be established for the client to join the lobby in the first place. Another question that could be asked is: "Why can I see floating players punching, holding items, attacking with said items, and firing guns?" which is because that information isn't sent client to client. The client swinging sends the packet to the host, and then then host sends a packet to the rest of the clients to handle

Though this method Dani used isn't exactly safe against cheaters who abuse it or good for the Steam P2P connection issues, it was good at updating player positions and rotations faster (as it'd take less time for packets to reach each other if there's no middle man) and also helped somewhat with internet bandwith usage. You can see it when looking at players far away on maps like Sussy Slope (the ice Race map with the large slide), the game sends less postion and rotation packets the further you are from somebody, resulting in them looking like they're telporting a couple units at a time

Now that I've gone over why floating players happen, I just want to say first of all this would be pretty easy for Dani to fix if he chose to do so, but he seems to be doing other stuff in life and hasn't touched this game in years, so it's understandable. But for now this patch is the best we can really do without needing everyone to have a mod that does the work for Dani. Now to explain how this simple mod works.

Essentially all the mod does is take the positions and rotations the clients send to you as the host, and then send those positions and rotations back out to all clients. Though this seems like a foolproof method of fixing the floating player issue, there are some caveats:
1. This does not actually fix the root issue of connections not being established between clients, but merely works around it with clients that were able to establish a connection with you as the host and actually get in the lobby. Some players *may* still have problems connecting and have to wait a while to join the lobby, meaning reaching player counts any higher than 30 or so *could* be difficult to reach
2. Clients that have established a secure connection will be receiving 2 of the same/similar position packets at slightly offset times due to ping. This *could* lead to players seeming to stutter back and forth at higher pings and lead to a slightly worse experience, may be especially apparent when playing close proximity or chase game modes like Tag
3. If you are afk or distant at the start or edges of large maps like Sussy Slope and several clients haven't established connections with each other, players at long distances will see players moving/teleporting several units at a time, which will also look awkward and *could* lead to flinging. As the host, it is in your best interest to be positioned closer to the center of the map or near the most players so that the experience of players doesn't feel as laggy. Clients with the mod will send their position to the host most frequently to try and get around this issue, but this requires the client to have the mod, and not all clients will
4. You will technically be using more network bandwidth using this mod, and it will grow exponentially the more players there are in your lobby. If you have slow or limited internet, I'd recommend sticking to hosting smaller lobbies and not using this mod, or only joining lobbies and not hosting them
5. This *could* amplify the effect of cheaters using player flinging cheats, due to caveat 1 where players may seem to stutter back and forth, if a cheater flings one or a couple players, those players could be more likely of flinging other nearby players as well

I do hope this mod can bring back some life to Crab Game, I find it very fun to play, and it's even better when played with a lobby of 30+ randoms lol


TLDR:
1. This mod does not fix the root issue causing the floating players, only working around the problem
2. Clients may see other players slightly or even majorly stuttering back and forth when moving with high pings or bad connections
3. As the host, you should aim to be near the majority of or as many players as you can, usually the center of the map
4. Clients with the mod will not need to be near the host in game
5. This mod will end up using more bandwith than you usually do, exponentially with higher player counts even
6. The effects of cheater's fling cheats *could* be amplified, and catching them will by default be harder with more players to rule out at larger lobby sizes

Happy hosting! :D


# New as of v1.2.0
## Smoother Movement (Client Side)
This will make you treat the host as if they're always nearby, meaning that you'll send them the same frequency of position and rotation updates, regardless of how far away you are.
This way, if the host has the mod, you won't appear as laggy to nearby players if the host is far away. Others without the mod that are nearby will still appear laggy to you.

## Only Establish Connection with Host (Client Side, Opt-in via Config)
This will make you only establish a connection with the host, so long as they are sharing that they have the mod.
This *may* allow you to join the game a bit faster (as you won't have to establish a bunch of pointless connections, though this is untested/unconfirmed) and will make you not send any packets to any other players besides the host.
This will also only make you accept player position and rotation packets from the host, meaning that no one can lie to you about their positon.
