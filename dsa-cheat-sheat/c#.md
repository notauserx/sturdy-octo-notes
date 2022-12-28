# PriorityQueue

```csharp
// min head
PriorityQueue<int, int> pq = new();
// max heap
PriorityQueue<int, int> pq = new(Comparer<int>.Create((a, b) => b.CompareTo(a)));

// put items in
pq.Enqueue(2,2);

// common pattern to iterate and dequeue until empty
while(pq.Count > 0) {
  var top = pq.Dequeue();
}
```

