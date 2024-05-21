from collections import deque

class Graph:
    def __init__(self, vertices):
        self.V = vertices
        self.graph = [[0 for _ in range(vertices)] for _ in range(vertices)]

    def add_edge(self, u, v, capacity):
        self.graph[u][v] = capacity
        self.graph[v][u] = 0

    def bfs(self, s, t, parent):
        vis = [False] * self.V
        queue = deque()
        queue.append(s)
        vis[s] = True

        while queue:
            u = queue.popleft()
            for v in range(self.V):
                if not vis[v] and self.graph[u][v] > 0:
                    queue.append(v)
                    vis[v] = True
                    parent[v] = u
        return vis[t]

    def rebro(self, source, sink):
        parent = [-1] * self.V
        max_flow = 0

        while self.bfs(source, sink, parent):
            path_flow = float("Inf")
            s = sink
            while s != source:
                path_flow = min(path_flow, self.graph[parent[s]][s])
                s = parent[s]

            max_flow += path_flow
            v = sink
            while v != source:
                u = parent[v]
                self.graph[u][v] -= path_flow
                self.graph[v][u] += path_flow
                v = parent[v]

        return max_flow

g = Graph(4)
g.add_edge(0, 1, 10)
g.add_edge(0, 2, 5)
g.add_edge(1, 2, 15)
g.add_edge(1, 3, 10)
g.add_edge(2, 3, 10)

source = 0
sink = 3

print(f"Максимальный поток: {g.rebro(source, sink)}")