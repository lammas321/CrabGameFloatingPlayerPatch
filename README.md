# CrabGameFloatingPlayerPatch
### A small BepInEx mod for Crab Game that patches* the floating player issue.

### Installation instructions at the bottom of this page!

This mod does have a soft dependency on [ModList](https://thunderstore.io/c/crab-game/p/lammas123/ModList/).

## What started the connection issues
Some time ago (around March 2024) after an update to the way Steam handles Peer2Peer connections (SteamP2P), Crab Game lobbies with around 12 or more players (getting worse the more there were) started seeing players just floating in place for the entirety of games, never moving or rotating, only punching and using items. The reason for this is whatever that Steam P2P update did made it more difficult to establish P2P connections with players, especially with those located further away or when the lobby has larger player counts. Personally, I suspect that Steam implemented some form of rate limit on how many connections can be established within a period of time/in total, which would explain why a ton of players joining at once, and larger lobbies in general, have these issues.

## What causes floating players
Most games will make clients send position and rotation data to the host for the host to verify, and then the host will either forward that information to all clients or block it if the data seems illegitimate or cheated, which is why server side anti cheats work. The problem with Crab Game is that this position and rotation isn't sent to the host and then to all players, rather it is sent directly from client to client with no host to verify it as the middle man. This technically means cheaters can lie to the host about their position to seem legit, and then use movement cheats and fling other players out the map without the host knowing who is doing it and I hate it, but that's getting off topic lol.

Because of this method of sharing player position and rotation data, and with players not being able to establish connections with each other due to the Steam P2P update, player position and rotation packets never reach each other, thus resulting in players floating indefinitely until a connection is randomly established. Some may ask the question: "Why does the server host never see any floating players?" and that's because a connection had to be established for the client to join the lobby in the first place. Until that connection is established, you will sit on the joining server screen. Another question that could be asked is: "Why can I see floating players punching, holding items, attacking with said items, and firing guns?" which is because that information isn't sent client to client. The client swinging sends the packet to the host, and then the host sends a packet to the rest of the clients to handle.

Though this method Dani used isn't exactly safe against cheaters who abuse it or good for the Steam P2P connection issues, it was good at updating player positions and rotations faster (as it'd take less time for packets to reach each other if there's no middle man) and also helped somewhat with internet bandwidth usage. You can see it when looking at players far away on maps like Sussy Slope (the ice Race map with the large slide), the game sends less position and rotation packets the further you are from somebody, resulting in them looking like they're teleporting a couple units at a time.

## How the mod works
### Server Side Floating Player Patch
As the host, when a player sends you their position or rotation, you immediately forward that to all clients. This, at the very least, prevents the floating players issue, but it does come with some caveats:

1. This does not actually fix the root issue of connections not being established between players, but merely works around it with clients that were able to establish a connection with you as the host and actually get in the lobby. Some players will still likely have problems connecting and have to wait a while to join the lobby, meaning reaching player counts any higher than 30 or so will likely be difficult to attain.

2. Vanilla clients that have established connections with other vanilla clients will be receiving 2 of the same/similar position packets at slightly offset times due to ping. This may lead to players seeming to stutter back and forth at higher pings and lead to a slightly worse experience, will will be especially apparent when playing close proximity or chase game modes like Tag, but I think it's a worthwhile trade off to make the game actually playable.

3. If you are distant from the rest of the players on large maps like Sussy Slope, and vanilla clients haven't established connections with each other, players at those long distances will see vanilla clients moving/teleporting several units at a time, which will look awkward and may lead to flinging. As the host, it is in your best interest to be positioned closer to the center of the map or near the most vanilla clients so that the experience of players doesn't feel as laggy. Clients with the mod will send their position to the host most frequently to try and get around this issue, but this requires the client to have the mod, and not all clients will.

4. You will be using more network bandwidth using this mod, and this will grow exponentially the more players there are in your lobby, especially so if more clients are using the mod. If you have slow or limited internet, I'd recommend sticking to hosting smaller lobbies and not using this mod, or only joining lobbies and not hosting them.

5. This may amplify the effect of cheaters using player flinging cheats, due to the first caveat where players may seem to stutter back and forth, if a cheater flings one or a couple players, those players may be more likely of flinging other nearby players as well.

I do hope this mod can bring back some life to Crab Game, I find it very fun to play, and it's even better when played with a lobby of 30+ randoms lol.

#### TLDR
1. This mod does not fix the root issue causing the floating players, only working around the problem (SteamP2P).

2. Clients may see other players slightly or even majorly stuttering back and forth when moving with high pings or bad connections.

3. As the host, you should aim to be near the majority of or as many players as you can, usually the center of the map.

4. This mod will end up using more bandwidth than you usually do, exponentially with higher player counts even.

5. The effects of cheater's fling cheats may be amplified, and catching them will by default be harder with more players to rule out at larger lobby sizes.

Happy hosting! :D

### Client Side Ignore Client Position Updates Patch
As a client with the mod, in a lobby where the host is also using the mod, you will ignore all connections with all other clients, meaning you won't receive player position and rotation updates from anyone besides the host. This also means voice chat won't be networked P2P like it normally is, it will be relayed through the host.

### Client Side Laggy Movement Patch
As a client with the mod, in a lobby where the host is also using the mod, you will send the host your player position and rotation updates more frequently. This forces your movement to other players to be more fluid, and less like you're teleporting if you're far away from the host.

### Client Side Host Priority Patch
As a client with the mod, joining any lobby, you will prioritize establishing a connection with the host before other clients. In theory, this should make the connection with the host establish faster and get you in the game sooner.

Additionally, while you're connecting the host, you'll be able to see your current connection state with them, and how long you've been waiting for that connection to establish.


# Installing FloatingPlayerPatch
Need help or wanna reach out? Do so on the Discord! https://discord.gg/jBGMZqndT3

## Mod Manager (r2modman)
1. Download and install [r2modman](https://thunderstore.io/c/crab-game/p/ebkr/r2modman/).

2. Create or open a profile for Crab Game.

3. Search for ['FloatingPlayerPatch' by lammas123](https://thunderstore.io/c/crab-game/p/lammas123/FloatingPlayerPatch/) under the Online tab and download the mod.

4. Start modded! If you do not see a BepInEx console window appear, and the game just launches normally, then you need to download the [C++ Redistributable](https://aka.ms/vs/17/release/vc_redist.x64.exe) installer and run it. This will make door stop able to work and allow BepInEx to do its thing.

5. If you see the BepInEx console window appear when starting the game modded, then you can now play with FloatingPlayerPatch!

## Manual Installation
[Manual Installation Video](https://www.youtube.com/watch?v=2dnf7JWObh8) by Storm

1. Download [BepInEx_UnityIL2CPP_x64_ec79ad0_6.0.0-be.577.zip](https://builds.bepinex.dev/projects/bepinex_be/577/BepInEx_UnityIL2CPP_x64_ec79ad0_6.0.0-be.577.zip) from [BepInEx Bleeding Edge Builds](https://builds.bepinex.dev/projects/bepinex_be).

2. Extract/unzip the file and put its contents (the "BepInEx" and "mono" folders with the "doorstop_config.ini" and "winhttp.dll" files) in your Crab Game directory (open your Steam Library, right click Crab Game, Manage -> Browse local files).

3. Run the game once, it should take a bit longer than usual. Once you reach the main menu, you can close the game and check if there are now multiple folders besides "core" in the "BepInEx" folder.

4. If the only folder present is "core", then you need to download the [C++ Redistributable](https://aka.ms/vs/17/release/vc_redist.x64.exe) installer and run it. This will make door stop able to work and allow BepInEx to do its thing.

5. Download the latest version of FloatingPlayerPatch from [Releases](https://github.com/lammas321/CrabGameFloatingPlayerPatch/releases) and move it into the new "BepInEx/plugins/" directory.

6. You can now run the game again and play with FloatingPlayerPatch!
