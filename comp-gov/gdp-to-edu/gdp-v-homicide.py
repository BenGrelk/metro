#%%
import numpy as np
import pandas as pd
import matplotlib.pyplot as plt
import scipy.stats as stats
#%%
df1 = pd.read_csv("data/national-gdp-penn-world-table.csv")
df2 = pd.read_csv("data/share-of-population-15-years-and-older-with-no-education.csv")
df3 = pd.read_csv("data/population.csv")

# Get 2020 data
year = 2020
df1 = df1[df1["Year"] == 2019]
df2 = df2[df2["Year"] == year]
df3 = df3[df3["Year"] == year]

# Join 1, 2, 3, on Entity
df = df1.merge(df2, on="Entity").merge(df3, on="Entity")
#%%
x_axis = df["GDP (output, multiple price benchmarks)"]
y_axis = df["Combined - percentage of youth and adults aged between 15 and 64 years with no education"]
population = df["Population (historical estimates)"]
#%%
points_of_interest = ["United States", "United Kingdom", "Russia", "China", "Iran", "Mexico", "Nigeria"]

# Make text in points_of_interest gold
colors = []
for country in df["Entity"]:
    if country in points_of_interest:
        colors.append("gold")
    else:
        colors.append("blue")

# Plot, bigger dots for bigger populations
plt.scatter(x_axis, y_axis, c=colors, alpha=0.5, s=population/1000000)
# Add labels to dots
for i, txt in enumerate(df["Entity"]):
    if txt in points_of_interest:
        # Smaller text, slightly to right and up
        plt.annotate(txt, (x_axis[i], y_axis[i]), fontsize=8, xytext=(5, 5), textcoords='offset points')


# Add labels
plt.title(f"Share of population with no education v GDP per capita, {year}")
plt.xlabel("GDP per capita")
plt.ylabel("Share of population with no education")

plt.xscale("log")

# Add regression line
slope, intercept, r_value, p_value, std_err = stats.linregress(x_axis, y_axis)

# Save figure to output.png
plt.savefig("output.png")
plt.show()

