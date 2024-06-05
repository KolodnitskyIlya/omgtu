import re

# Функция для замены ключа в строке
def replace_key(match, super_potion):
    return super_potion[int(match.group())]

# Чтение данных из файла и создание словаря суперзелья
def read_super_potion(filename):
    with open(filename) as file:
        lines = [line.strip() for line in file.readlines()]
        return {i+1: line for i, line in enumerate(lines)}

# Выполнение замен по условиям
def apply_replacements(super_potion):
    for key in super_potion.keys():
        super_potion[key] = re.sub(r'\b\d+\b', lambda x: replace_key(x, super_potion), super_potion[key])
        if 'WATER ' in super_potion[key]:
            super_potion[key] = 'WT' + super_potion[key].replace('WATER', '') + ' TW'
        if 'DUST ' in super_potion[key]:
            super_potion[key] = 'DT' + super_potion[key].replace('DUST', '') + ' TD'
        if 'MIX ' in super_potion[key]:
            super_potion[key] = 'MX' + super_potion[key].replace('MIX', '') + ' XM'
        if 'FIRE ' in super_potion[key]:
            super_potion[key] = 'FR' + super_potion[key].replace('FIRE', '') + ' RF'
    return super_potion

# Вывод результата без пробелов
def print_result(super_potion, num_lines):
    print(super_potion[num_lines].replace(' ', ''))

# Основная часть программы
if __name__ == "__main__":
    input_file = 'input2.txt'
    super_potion = read_super_potion(input_file)
    super_potion = apply_replacements(super_potion)
    print_result(super_potion, len(super_potion))