<template>
  <button @click="handleClick" :class="{ active: isActive }">
    <slot></slot>
  </button>
</template>

<script lang="ts">
import { defineComponent, ref } from "vue";

export default defineComponent({
  name: "DefaultButton",
  setup() {
    const isActive = ref(false);

    const handleClick = () => {
      isActive.value = !isActive.value;
    };

    return { isActive, handleClick };
  },
});
</script>

<style scoped>
button {
  background-color: #2c64fc;
  color: white;
  border: none;
  border-radius: 5px;
  padding: 8px 16px;
  cursor: pointer;
  transition: background-color 0.3s ease;
}

button:hover {
  background-color: #1f1f1f;
}

.active {
}
</style>
