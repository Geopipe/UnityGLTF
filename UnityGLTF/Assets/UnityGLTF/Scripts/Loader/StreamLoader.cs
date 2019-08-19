using System.IO;
using GLTF;
using UnityEngine;
using System;
using System.Collections;
using System.Threading.Tasks;

namespace UnityGLTF.Loader
{
	public class StreamLoader : ILoader
	{
		public Stream LoadedStream { get; private set; }

		public bool HasSyncLoadMethod { get; private set; }

		public StreamLoader(Stream stream)
		{
			LoadedStream = stream;
			HasSyncLoadMethod = true;
		}

		public Task LoadStream(string dummy) {
			return Task.Run(() => {});
		}

		public void LoadStreamSync(string dummy) { }
 	}
}
