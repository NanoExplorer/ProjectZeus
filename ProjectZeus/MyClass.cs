using System;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Text;
using KSP;
using UnityEngine;

namespace ProjectZeus
{
	[KSPAddon(KSPAddon.Startup.Flight, false)]
	public class MyClass : KSPPluginFramework.MonoBehaviourExtended
	{

		internal override void Awake()
		{

		}

		internal override void OnDestroy()
		{
			//tear down the server (do the opposite of Awake())
		}

		internal override void OnDisable()
		{
			//I think do the same thing as onDestroy()
		}

		internal override void OnEnable()
		{
			//rebuild the stuff removed by ondisable
		}

		internal override void RepeatingWorker()
		{
			//This will poll the server for commands maybe 5-10 times per second.
		}


	}
}

