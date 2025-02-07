# O(n) time and O(1) space

def getUniqueFileNames(names):
    seen = set()
    result = []
    for name in names:
        if name not in seen:
            seen.add(name)
            result.append(name)
        else:
            i = 1
            new_name = f"{name}({i})"
            while new_name in seen:
                i += 1
                new_name = f"{name}({i})"
            seen.add(new_name)
            result.append(new_name)
    return result
