/*
Copyright 2004-2012 Hugo Anton Feldhammer, Urs Geissbühler, Daniel Milner


This file is part of Net Profiles mod.

Net Profiles mod is free software: you can redistribute it and/or modify
it under the terms of the GNU General Public License as published by
the Free Software Foundation, either version 3 of the License, or
(at your option) any later version.

Net Profiles mod is distributed in the hope that it will be useful,
but WITHOUT ANY WARRANTY; without even the implied warranty of
MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
GNU General Public License for more details.

You should have received a copy of the GNU General Public License
along with Net Profiles mod.  If not, see <http://www.gnu.org/licenses/>.
*/

/*
Based on sample code released at http://www.nullskull.com/articles/20060414.asp with no specific license
*/

namespace System.Collections
{
	using System.Threading;

	/// <summary>
	/// Same as Queue except Dequeue function blocks until there is an object to return.
	/// Note: This class does not need to be synchronized
	/// </summary>
	public class BlockingQueue : Queue
	{
		private bool open;

		/// <summary>
		/// Create new BlockingQueue.
		/// </summary>
		/// <param name="col">The System.Collections.ICollection to copy elements from</param>
		public BlockingQueue(ICollection col) : base(col)
		{
			open = true;
		}

		/// <summary>
		/// Create new BlockingQueue.
		/// </summary>
		/// <param name="capacity">The initial number of elements that the queue can contain</param>
		/// <param name="growFactor">The factor by which the capacity of the queue is expanded</param>
		public BlockingQueue(int capacity, float growFactor) : base(capacity, growFactor)
		{
			open = true;
		}

		/// <summary>
		/// Create new BlockingQueue.
		/// </summary>
		/// <param name="capacity">The initial number of elements that the queue can contain</param>
		public BlockingQueue(int capacity) : base(capacity)
		{
			open = true;
		}

		/// <summary>
		/// Create new BlockingQueue.
		/// </summary>
		public BlockingQueue() : base()
		{
			open = true;
		}

		/// <summary>
		/// BlockingQueue Destructor (Close queue, resume any waiting thread).
		/// </summary>
		~BlockingQueue()
		{
			Close();
		}

		/// <summary>
		/// Remove all objects from the Queue.
		/// </summary>
		public override void Clear()
		{
			lock (base.SyncRoot)
			{
				base.Clear();
			}
		}

		/// <summary>
		/// Remove all objects from the Queue, resume all dequeue threads.
		/// </summary>
		public void Close()
		{
			lock (base.SyncRoot)
			{
				open = false;
				base.Clear();
				Monitor.PulseAll(base.SyncRoot); // resume any waiting threads
			}
		}

		/// <summary>
		/// Removes and returns the object at the beginning of the Queue.
		/// </summary>
		/// <returns>Object in queue.</returns>
		public override object Dequeue()
		{
			return Dequeue(Timeout.Infinite);
		}

		/// <summary>
		/// Removes and returns the object at the beginning of the Queue.
		/// </summary>
		/// <param name="timeout">time to wait before returning</param>
		/// <returns>Object in queue.</returns>
		public object Dequeue(TimeSpan timeout)
		{
			return Dequeue(timeout.Milliseconds);
		}

		/// <summary>
		/// Removes and returns the object at the beginning of the Queue.
		/// </summary>
		/// <param name="timeout">time to wait before returning (in milliseconds)</param>
		/// <returns>Object in queue.</returns>
		public object Dequeue(int timeout)
		{
			lock (base.SyncRoot)
			{
				while (open && (base.Count == 0))
				{
					if (!Monitor.Wait(base.SyncRoot, timeout))
						throw new InvalidOperationException("Timeout");
				}
				if (open)
					return base.Dequeue();
				else
					throw new InvalidOperationException("Queue Closed");
			}
		}

		/// <summary>
		/// Adds an object to the end of the Queue.
		/// </summary>
		/// <param name="obj">Object to put in queue</param>
		public override void Enqueue(object obj)
		{
			lock (base.SyncRoot)
			{
				base.Enqueue(obj);
				Monitor.Pulse(base.SyncRoot);
			}
		}

		/// <summary>
		/// Open Queue.
		/// </summary>
		public void Open()
		{
			lock (base.SyncRoot)
			{
				open = true;
			}
		}

		/// <summary>
		/// Gets flag indicating if queue has been closed.
		/// </summary>
		public bool Closed
		{
			get { return !open; }
		}
	}
}