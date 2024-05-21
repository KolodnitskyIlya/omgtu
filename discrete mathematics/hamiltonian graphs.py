def is_hamiltonian(graph, path=[]):
    if len(path) == 0:
        for node in graph:
            new_path = path + [node]
            if is_hamiltonian(graph, new_path):
                return True
    else:
        last_node = path[-1]
        if len(path) == len(graph):
            if path[0] in graph[last_node]:
                return True
        else:
            for node in graph[last_node]:
                if node not in path:
                    new_path = path + [node]
                    if is_hamiltonian(graph, new_path):
                        return True
    return False

# Пример использования
graph = {
    1: [2, 3],
    2: [1, 3, 4],
    3: [1, 2, 4],
    4: [2, 3]
}

if is_hamiltonian(graph):
    print("Гамильтонов цикл существует.")
else:
    print("Гамильтонов цикл не существует.")
